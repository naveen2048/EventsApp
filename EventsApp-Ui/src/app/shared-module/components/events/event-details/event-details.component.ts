import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-event-details',
  templateUrl: './event-details.component.html',
  styleUrls: ['./event-details.component.css']
})
export class EventDetailsComponent implements OnInit {

  @Input() event:any ={
    id:1,
    category: 'Music',
    description: 'Arijit Singh concert LIVE in US',
    location: 'Hyderabad',
    date:'December 25, 2019'
  };

  constructor() { }

  ngOnInit() {
  }

}
