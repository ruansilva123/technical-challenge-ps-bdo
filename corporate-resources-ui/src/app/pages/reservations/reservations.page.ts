import { Component } from '@angular/core';
import { FooterComponent } from '../../shared/components/footer/footer.component';
import { HeaderComponent } from '../../shared/components/header/header.component';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { provideNativeDateAdapter } from '@angular/material/core';
import { MatTableModule } from '@angular/material/table';
import { MatIconModule } from '@angular/material/icon';
import { MatTooltipModule } from '@angular/material/tooltip';
import { Router } from '@angular/router';

@Component({
    selector: 'app-reservations',
    standalone: true,
    imports: [
        FooterComponent,
        HeaderComponent,
        FormsModule,
        MatFormFieldModule,
        MatInputModule,
        MatDatepickerModule,
        MatTableModule,
        MatIconModule,
        MatTooltipModule
    ],
    providers: [provideNativeDateAdapter()],
    templateUrl: './reservations.page.html',
    styleUrl: './reservations.page.scss'
})
export class ReservationsPage {
    private router: Router;

    protected displayedColumns: string[] = ['Item', 'Category', 'City', 'LoanedTo', 'StartReservation', 'EndReservation'];
    protected dataSource = [];

    constructor(router: Router) {
        this.router = router;
    }

    protected goToReservationForm() {
        this.router.navigate(['/reservations/create']);
    }
}
