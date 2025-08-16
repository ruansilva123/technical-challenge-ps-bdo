import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'app-header',
    standalone: true,
    imports: [],
    templateUrl: './header.component.html',
    styleUrl: './header.component.scss'
})
export class HeaderComponent {
    private router: Router;

    constructor(router: Router) {
        this.router = router;
    }

    protected handleNavigate(url: string) {
        this.router.navigate([url]);
    }

    protected isActive(urls: string[]) {
        return urls.includes(this.router.url);
    }
}
