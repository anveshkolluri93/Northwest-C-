import { Home } from './home/Home';
import { About } from './about/About';
import { People } from './people/People';
import { PersonDetail } from './people/PersonDetail';
import { Route, Router } from 'angular2/router';
import {My} from './my/My';
import {Anvesh} from './anvesh/Anvesh';

export var Routes = {
  home: new Route({path: '/', as: 'Home', component: Home}),
  about: new Route({path: '/about', as: 'About', component: About}),
  people: new Route({ path: '/people', as: 'People', component: People }),
  my: new Route({ path: '/my', as: 'My', component: My }),
  anvesh: new Route({ path: '/anvesh', as: 'Anvesh', component: Anvesh  }),
  detail: new Route({ path: '/people/:id', as: 'Detail', component: PersonDetail })

};

export const APP_ROUTES = Object.keys(Routes).map(r => Routes[r]);
