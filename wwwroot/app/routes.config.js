var Home_1 = require('./home/Home');
var About_1 = require('./about/About');
var People_1 = require('./people/People');
var PersonDetail_1 = require('./people/PersonDetail');
var router_1 = require('angular2/router');
var My_1 = require('./my/My');
var Anvesh_1 = require('./anvesh/Anvesh');
exports.Routes = {
    home: new router_1.Route({ path: '/', as: 'Home', component: Home_1.Home }),
    about: new router_1.Route({ path: '/about', as: 'About', component: About_1.About }),
    people: new router_1.Route({ path: '/people', as: 'People', component: People_1.People }),
    my: new router_1.Route({ path: '/my', as: 'My', component: My_1.My }),
    anvesh: new router_1.Route({ path: '/anvesh', as: 'Anvesh', component: Anvesh_1.Anvesh }),
    detail: new router_1.Route({ path: '/people/:id', as: 'Detail', component: PersonDetail_1.PersonDetail })
};
exports.APP_ROUTES = Object.keys(exports.Routes).map(function (r) { return exports.Routes[r]; });
