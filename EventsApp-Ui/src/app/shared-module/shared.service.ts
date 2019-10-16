import { Injectable } from '@angular/core';
import { Subject, Observable, BehaviorSubject, of } from 'rxjs';
import { eventModel } from '../models/event-model';

@Injectable({
  providedIn: 'root'
})
export class MessageService {
private events = new BehaviorSubject<eventModel[]>([]);
fetchdData = this.events.asObservable();

data: eventModel[] = [
  {
    id: 1,
    category: 'Music',
    description: 'Arijit Singh concert LIVE in US',
    location: 'Hyderabad',
    date: 'December 25, 2019',
    title: 'Arijit US Tour'
  },
  {
    id: 2,
    category: 'Technology Gather',
    description: 'Meet with all big Tech Companies',
    location: 'Mumbai',
    date: 'October 14, 2019',
    title: 'SEC 2019'
  },
  {
    id: 3,
    category: 'Technology Gather',
    description: 'Meet with all big Tech Companies',
    location: 'Mumbai',
    date: 'October 14, 2019',
    title: 'Technology meet'
  },
  {
    id: 4,
    category: 'Technology Gather',
    description: 'Meet with all big Tech Companies',
    location: 'Mumbai',
    date: 'October 14, 2019',
    title: 'Tech of the future'
  }
];

  constructor() { }

  filterEvents(_events:eventModel[]){
    this.events.next(_events);
  }

  getFilterEvents(): Observable<eventModel[]> {
    return of(this.data);
  }
}

