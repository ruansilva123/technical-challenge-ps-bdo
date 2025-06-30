import { Component } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-vehicles',
  standalone: true,
  imports: [],
  templateUrl: './vehicles.component.html',
  styleUrl: './vehicles.component.scss'
})

export class VehiclesComponent {
  constructor(private toastr: ToastrService){
    this.toastr.warning("Vehicles page in develop!");
  }
}
