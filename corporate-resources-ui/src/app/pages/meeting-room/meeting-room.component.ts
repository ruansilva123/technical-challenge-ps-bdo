import { Component } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-meeting-room',
  standalone: true,
  imports: [],
  templateUrl: './meeting-room.component.html',
  styleUrl: './meeting-room.component.scss'
})

export class MeetingRoomComponent {
  constructor(private toastr: ToastrService) {
    this.toastr.warning("Meeting Room page in develop!");
  }
}
