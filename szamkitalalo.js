/*
console.log(Math.random())
console.log(Math.random()*90+1)
console.log(Math.floor(Math.random() * 90) + 1);
*/
       

function veletlenSzam(min=1,max=90) {
    return Math.floor(Math.random() * (max-min+1) ) + min; 
}
const valasz = document.getElementById("valasz");
const gondoltSzam = veletlenSzam(1,100);
valasz.innerHTML = "A gondolt szám: "+gondoltSzam+'<br>';

// vagy ||  illetve és &&
function szamEllenorzes(szam) {
  if (szam < 1 || szam > 100 || isNaN(szam)) {
   valasz.innerHTML += "Hibás bevitel:"+szam+'<br>';
  } else {
    // jó
    if (szam < gondoltSzam) {
      valasz.innerHTML += "A gondolt szám nagyobb<br>"
    }
    else if (szam > gondoltSzam) {
      valasz.innerHTML += "A gondolt szám kisebb<br>"
    }
    else {
      valasz.innerHTML += "Gratulálok, eltaláltad!<br>"
    }

  
  }
}





//console.log(veletlenSzam());
//console.log(veletlenSzam(119,120));
/*
let kiirasDiv = document.getElementById("kiiras");
for (let i = 0; i < 5; i++) {
    let szam = veletlenSzam();
    kiirasDiv.innerHTML += `${szam}`;
    if (i<4) {
        kiirasDiv.innerHTML += ',';
    }
}
*/

