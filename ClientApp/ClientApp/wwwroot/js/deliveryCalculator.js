ymaps.ready(init);

//запрос карты по кордам https://yandex.by/maps/?ll=auto&mode=routes&rtext={ax}%2C{ay}~{bx}%2C{by}&rtt=auto&ruri=~&z=auto

function init() {
    myMap = new ymaps.Map('map', {
        center: [53.9, 27.5667],
        zoom: 9,
        controls: ['geolocationControl']
    }, {
        // Зададим ограниченную область прямоугольником, примерно описывающим Беларусь.
        restrictMapArea: [
            [51.506137, 22.915326],
            [56.020608, 32.687664]
        ]
    }),

        // Создадим панель маршрутизации.
        routePanelControl = new ymaps.control.RoutePanel({
            options: {
                // Добавим заголовок панели.
                showHeader: true,
                title: 'Расчёт доставки',
                textColole: 0x000000
            }
        }),
        zoomControl = new ymaps.control.ZoomControl({
            options: {
                size: 'small',
                float: 'none',
                position: {
                    bottom: 145,
                    right: 10
                }
            }
        });
    // Пользователь сможет построить только автомобильный маршрут.
    routePanelControl.routePanel.options.set({
        types: { auto: true }
    });

    // Если вы хотите задать неизменяемую точку "откуда", раскомментируйте код ниже.
    /*routePanelControl.routePanel.state.set({
        fromEnabled: false,
        from: 'Москва, Льва Толстого 16'
     });*/

    myMap.controls.add(routePanelControl).add(zoomControl);

    // Получим ссылку на маршрут.
    routePanelControl.routePanel.getRouteAsync().then(function (route) {

        // Зададим максимально допустимое число маршрутов, возвращаемых мультимаршрутизатором.
        route.model.setParams({ results: 1 }, true);

        // Повесим обработчик на событие построения маршрута.
        route.model.events.add('requestsuccess', function () {

            let activeRoute = route.getActiveRoute();
            if (activeRoute) {
                // Получим протяженность маршрута.
                let length = route.getActiveRoute().properties.get("distance"),
                    // Вычислим стоимость доставки.
                    price = calculate(length.value),
                    // Создадим макет содержимого балуна маршрута.
                    balloonContentLayout = ymaps.templateLayoutFactory.createClass(
                        '<span>Расстояние: ' + length.text + '.</span><br/>' +
                        '<span style="font-weight: bold; font-style: italic">Стоимость доставки: ' + price.toFixed(2) + ' BYN.</span>');
                // Зададим этот макет для содержимого балуна.
                route.options.set('routeBalloonContentLayout', balloonContentLayout);
                // Откроем балун.
                activeRoute.balloon.open();

                DISTANCE = parseFloat((length.value / 1000).toFixed(2));
                COST = parseFloat(price.toFixed(2));
                countCosts();
                ACTIVE_ROUTE = activeRoute;
                //console.log(activeRoute?.properties);
                console.log(price, DISTANCE);
            }

        });

    });
    // Функция, вычисляющая стоимость доставки.
    function calculate(routeLength) {
        let length = routeLength / 1000 * DELIVERY_TARIFF;
        length = parseFloat(length.toFixed(2));
        return Math.max(length, MINIMUM_COST);
    }
}