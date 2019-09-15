import { Injectable } from '@angular/core';
import {Seating} from '../Models/Seating';
import {Http} from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { map } from "rxjs/operators";

@Injectable()
export class SeatingService {
seatinglist : Seating[];
  constructor(private http: Http) {
    
   }
getseatlist():Observable<Seating[]>{
  console.log("Get List")
  return this.http.get("https://localhost:5001/api/SeatingNew").pipe(map(result=>{
    this.seatinglist=result.json();
    console.log("Result",this.seatinglist);
    return result.json();
  }))
}
AddSeating(seat : Seating) {
  console.log("in service",seat);
  return this.http.post("https://localhost:5001/api/SeatingNew",seat ).pipe(
    map(data => {
      console.log("in service", data);
      return data.json();
    })
  );
}
}
