import { Component } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-equipments',
  standalone: true,
  imports: [],
  templateUrl: './equipments.component.html',
  styleUrl: './equipments.component.scss'
})

export class EquipmentsComponent {
  constructor (private toastr: ToastrService) {
    this.toastr.warning("Equipment page in develop!");
  }
}
