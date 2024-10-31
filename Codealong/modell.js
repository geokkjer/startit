// Sykkelutleie
// Kunden ønsker en applikasjon som skal kunne liste opp syklene den har så andre kan leie dem. Det skal også være mulig å legge til nye sykler etterhvert.
// Lag en modell som kan fungere til teksten ovenfor
// Lag viewfunksjon for å vise frem alle syklene våre
// Lag en controllerfunksjon og et view til for å kunne legge til nye sykler
const app = document.getElementById('app');

const modell = {
    app: {
        
    },
    input: {

    },
    data: {
        bikes: [
             {
                id: 1,
                modell: 'DBS',
                gears: 5,
                description: '',
                state: 'works',
                isAvilable: true,

            },
            {
                id: 2,
                modell: 'DBS',
                gears: 7,
                description: '',
                state: 'refurbished',
                isAvilable: true,
            },
    ]
    },
}