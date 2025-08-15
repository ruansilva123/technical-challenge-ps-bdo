import { Component } from '@angular/core';
import { Router } from '@angular/router';
import {MatIconModule} from '@angular/material/icon';

@Component({
    selector: 'app-not-found',
    standalone: true,
    imports: [
        MatIconModule
    ],
    templateUrl: './not-found.page.html',
    styleUrl: './not-found.page.scss'
})
export class NotFoundPage {
    private router: Router;

    constructor(router: Router) {
        this.router = router;
    }

    protected redirectHomePage() {
        this.router.navigate(['/home']);
    }
}