import { Component } from '@angular/core';
import { FooterComponent } from '../../shared/components/footer/footer.component';
import { HeaderComponent } from '../../shared/components/header/header.component';

@Component({
    selector: 'app-reservations',
    standalone: true,
    imports: [
        FooterComponent,
        HeaderComponent
    ],
    templateUrl: './reservations.page.html',
    styleUrl: './reservations.page.scss'
})
export class ReservationsPage {

}
