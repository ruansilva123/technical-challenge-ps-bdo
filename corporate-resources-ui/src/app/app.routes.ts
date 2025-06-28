import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { MeetingRoomComponent } from './pages/meeting-room/meeting-room.component';
import { VehiclesComponent } from './pages/vehicles/vehicles.component';
import { EquipmentsComponent } from './pages/equipments/equipments.component';
import { PageNotFoundComponent } from './shared/request-templates/page-not-found/page-not-found.component';

export const routes: Routes = [
    {
        path: "",
        component: HomeComponent
    },
    {
        path: "home",
        component: HomeComponent
    },
    {
        path: "meeting-room",
        component: MeetingRoomComponent
    },
    {
        path: "vehicles",
        component: VehiclesComponent
    },
    {
        path: "equipments",
        component: EquipmentsComponent
    },
    {
        path: "**",
        component: PageNotFoundComponent
    }
];
