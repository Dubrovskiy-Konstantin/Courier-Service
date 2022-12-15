function countCosts() {
    let distanceCost = COST;
    let moversMultiplier = MOVERS_COST;
    let movers = document.querySelector('#movers').value;
    let totalCost = distanceCost + movers * moversMultiplier * distanceCost;
    document.querySelector('#costs').value = parseFloat(totalCost).toFixed(2) + " BYN";

    TOTAL_COST = parseFloat(totalCost);
}

document.querySelector('#movers').addEventListener('change', countCosts);
countCosts();