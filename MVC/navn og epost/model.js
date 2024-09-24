const model = {
    app: {
        page: 'search'
    },

    inputs : {
        search: {
            text: '',
        },
        createNew: {
            name: '',
            email: '',
        },
        delete: {
            areYouSure: false,
            personId: null,
        },
        edit: {
            personId: null,
            name: '',
            email: '',
        },
    },

    // felles data
    people: [
        { id: 1, name: 'Per', email: 'per@mail.com'},
    ],

    
}