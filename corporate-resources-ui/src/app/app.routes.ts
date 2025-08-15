import { Routes } from '@angular/router';
import { NotFoundPage } from './pages/not-found/not-found.page';
import { HomePage } from './pages/home/home.page';

export const routes: Routes = [
    {
        path: "",
        component: HomePage
    },
    {
        path: "home",
        component: HomePage
    },
    {
        path: "**",
        component: NotFoundPage
    }
];