import { Routes } from '@angular/router';
import { NotFoundPage } from './pages/not-found/not-found.page';
import { HomePage } from './pages/home/home.page';
import { ReservationFormPage } from './pages/reservation-form/reservation-form.page';
import { ReservationsPage } from './pages/reservations/reservations.page';

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
        path: "reservations",
        component: ReservationsPage
    },
    {
        path: "reservations/create",
        component: ReservationFormPage
    },
    {
        path: "**",
        component: NotFoundPage
    }
];