import { Component, OnInit } from '@angular/core';
import {Booking} from '../../Models/Booking';
import { BookingService } from '../../Services/booking.service';
@Component({
  selector: 'app-booking',
  templateUrl: './booking.component.html',
  styleUrls: ['./booking.component.css']
})
export class BookingComponent implements OnInit {
booking : Booking;
  constructor(private bookingservice : BookingService) { }

  ngOnInit() {
    let count=0;
    setInterval(()=>{
      console.log("Count",count++);
      this.bookingservice.getBookingList().subscribe(result=>{
        console.log("Booking list", result);
      })
    },3000000000000000);

  }

}
