// Sykkelutleie
// Kunden ønsker en applikasjon som skal kunne liste opp syklene den har så andre kan leie dem. Det skal også være mulig å legge til nye sykler etterhvert.
// Lag en modell som kan fungere til teksten ovenfor
// Lag viewfunksjon for å vise frem alle syklene våre
// Lag en controllerfunksjon og et view til for å kunne legge til nye sykler
const header = document.getElementById('header');
const main = document.getElementById('main');
const input = document.getElementById('input');
const model = {
    app: {
        
    },
    input: {
        newBike: {
            brand: '',
            gears: 0,
            state: '',
            description: '',
            isAvilable: true,
        }
    },
    data: {
        bikes: [
             {
                id: 1,
                brand: 'DBS',
                gears: 5,
                description: '5 gir er veldig tungt',
                state: 'works',
                isAvilable: true,

            },
            {
                id: 2,
                brand: 'DBS',
                gears: 7,
                description: 'forhjulet er litt skeivt',
                state: 'refurbished',
                isAvilable: true,
            },
    ]
    },
}