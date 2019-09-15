import { Component, OnInit } from '@angular/core';
import { SeatingService } from '../../Services/seating.service';
import { Seating } from '../../Models/Seating';
import { Guid } from "guid-typescript";
import { Booking } from '../../Models/Booking';
import { BookingService } from '../../Services/booking.service';
@Component({
  selector: 'app-seating',
  templateUrl: './seating.component.html',
  styleUrls: ['./seating.component.css']
})
export class SeatingComponent implements OnInit {
  seatlist: Seating[];
  seating : Seating= new Seating();
  booking: Booking = new Booking();
  // selectedHero:Hero = new Hero();
  seatId: string;
  selecting = false;
  constructor(private seatservice: SeatingService, private bookService: BookingService) {

  }

  ngOnInit() {
    this.seatservice.getseatlist().subscribe(result => {
      console.log("Inside oninite",result);
      this.seatlist = result;
    })
  }
  bookingTable(id: string) {
    this.selecting = true;
    this.seatId = id;
  }
  AddSeat(seat : Seating){
    let seatId=Guid.create().toString();
    console.log("Guid", seatId);
    seat.Id=seatId;
    console.log("In side ", seat);
    this.seatservice.AddSeating(seat).subscribe(result=>{
    console.log("Seatresult", result);
    })

  }
  bookingtable(book: Booking) {
    book.Id = Guid.create().toString();
    book.SeatId = this.seatId;
    console.log("Selecting", book);
    this.bookService.addBooking(book).subscribe(result => {
      console.log("Booking", result);
      this.selecting = false;
    })
  }
}
