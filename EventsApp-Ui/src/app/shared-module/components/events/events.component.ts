import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})
export class EventsComponent implements OnInit {

  data = [{
    category: 'Music',
    description: 'Arijit Singh concert LIVE in US',
    location: 'Hyderabad'
  },
  {
    category: 'Technology Gather',
    description: 'Meet with all big Tech Companies',
    location: 'Mumbai'
  }
];
  constructor() { }

  ngOnInit() {
  }

}
