import { Component } from '@angular/core';
import { HeaderComponent } from '../../shared/components/header/header.component';
import { FooterComponent } from "../../shared/components/footer/footer.component";

@Component({
    selector: 'app-home',
    standalone: true,
    imports: [
        HeaderComponent,
        FooterComponent
    ],
    templateUrl: './home.page.html',
    styleUrl: './home.page.scss'
})
export class HomePage {

}
