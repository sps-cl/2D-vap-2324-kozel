var done = 0;
var request = 0;
var table;

function vytvoritTabulku() {
    var radek = document.getElementById("pocet-radku");
    var sloupec = document.getElementById("pocet-sloupcu");
    var bunka = 0;
    request = 1;
    if(done == 1 && request == 1 ){
        table.remove();
    }

    table = document.createElement("table");
    var pocetRadku = radek.value
    var pocetSloupcu = sloupec.value
    for(var i = 0; i < pocetRadku; i++) {
        var row = table.insertRow(i);
        for(let j = 0; j < pocetSloupcu; j++) {
            var cell = row.insertCell(j);
            bunka+=1;
            cell.textContent = bunka;
        }
    }
    document.body.appendChild(table);
    done = 1;
    request = 0;
}