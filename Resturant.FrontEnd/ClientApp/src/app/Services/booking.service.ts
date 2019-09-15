import { Injectable } from '@angular/core';
import {Seating} from '../Models/Seating';
import {Booking} from '../Models/Booking';
import {Http} from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { map } from "rxjs/operators";

@Injectable()
export class BookingService {
  bookingList : Booking[];
  constructor(private http : Http) { }
addBooking(booking : Booking) {
  console.log("in booking", booking);
  return this.http.post("https://localhost:5001/api/BookingNew",booking ).pipe(
    map(data => {
      console.log("in booking", data);
      return data.json();
    })
  );
}
getBookingList():Observable<Booking[]>{
  
    return this.http.get("https://localhost:5001/api/BookingNew").pipe(map(result=>{
      this.bookingList=result.json();
      console.log("Result",this.bookingList);
      return result.json();
    }))

  

}
}
