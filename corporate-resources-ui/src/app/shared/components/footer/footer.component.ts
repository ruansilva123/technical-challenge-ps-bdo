import { Component } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
    selector: 'app-footer',
    standalone: true,
    imports: [],
    templateUrl: './footer.component.html',
    styleUrl: './footer.component.scss'
})
export class FooterComponent {
    private email: string = 'ruancsilva123@icloud.com';

    constructor(private toastr: ToastrService) {}

    protected copyEmail() {
        navigator.clipboard.writeText(this.email).then(() => {
            this.toastr.success(undefined, "Email copied");
        }).catch(error => {
            this.toastr.error(undefined, "Error copying email");
        });
    }
}