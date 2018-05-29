import { Evento } from './evento';

export const Coordinates: Evento[] =
    [
        {
            nombre: 'ALoha Fest',
            descripcion: 'Fiesta aloha da la bienvenida a la primavera',
            fecha: new Date(1995, 8, 1),
            tipo: 'fiesta',
            organizador: 'Aloha',
            lat: -17.391848,
            long: -66.256003
        },
        {
            nombre: 'Cumbia Fest',
            tipo: 'musica',
            fecha: new Date(1995, 8, 1),
            descripcion: '',
            organizador: 'Cumbia Kings',
            lat: -17.389605,
            long: -66.261656
        },
        {
            nombre: 'Concierto Filarmonica',
            tipo: 'musica',
            fecha: new Date(1995, 8, 1),
            descripcion: '',
            organizador: 'Aloha',
            lat: -17.394404,
            long: -66.276059
        },
        {
            nombre: 'Campeonato Natacion',
            tipo: 'deportes',
            fecha: new Date(1995, 8, 1),
            descripcion: '',
            organizador: 'Aloha',
            lat: -17.392602,
            long: -66.280608
        },
        {
            nombre: 'Ballet Ruso',
            tipo: 'teatro',
            fecha: new Date(1995, 8, 1),
            descripcion: 'El ballet ruso llega a Bolivia.',
            organizador: 'Ballet Nacional',
            lat: -17.391056,
            long: -66.284674
        },
        {
            nombre: 'Concierto CafeTacvba',
            tipo: 'musica',
            fecha: new Date(1995, 8, 1),
            descripcion: 'El primer concierto de cafe tacvba en Bolivia.',
            organizador: 'KingRecords',
            lat: -17.359326,
            long: -66.165080
        }

    ];
