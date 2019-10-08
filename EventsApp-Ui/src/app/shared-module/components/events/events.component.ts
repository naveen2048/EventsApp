import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})
export class EventsComponent implements OnInit {

  data = [{
    id:1,
    category: 'Music',
    description: 'Arijit Singh concert LIVE in US',
    location: 'Hyderabad',
    date:'December 25, 2019'
  },
  {
    id:2,
    category: 'Technology Gather',
    description: 'Meet with all big Tech Companies',
    location: 'Mumbai',
    date:'October 14, 2019'
  },
  {
    id:3,
    category: 'Technology Gather',
    description: 'Meet with all big Tech Companies',
    location: 'Mumbai',
    date:'October 14, 2019'
  },
  {
    id:4,
    category: 'Technology Gather',
    description: 'Meet with all big Tech Companies',
    location: 'Mumbai',
    date:'October 14, 2019'
  }
];
  constructor() { }

  ngOnInit() {
  }

  share() {
    alert("Share me !!!");
  }
}
