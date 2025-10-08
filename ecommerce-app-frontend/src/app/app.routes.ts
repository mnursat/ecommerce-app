import { Routes } from '@angular/router';
import { Home } from './pages/home/home';

export const routes: Routes = [
    {
        path: '',
        component: Home
    },
    {
        path: 'home',
        redirectTo: '',
        pathMatch: 'full'
    }
];
