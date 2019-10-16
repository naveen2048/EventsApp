import { Component, OnInit, OnDestroy } from '@angular/core';
import { eventModel } from 'src/app/models/event-model';
import { MessageService } from '../../shared.service';
import { Subscription, Observable } from 'rxjs';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})
export class EventsComponent implements OnInit, OnDestroy {
  datax: eventModel[] = [];

  data: eventModel[];// = [];
  subscription: Subscription;

  constructor(private messageService: MessageService) {
    this.messageService.getFilterEvents().subscribe(events => {
      this.data = events;
    });
  }

  ngOnInit() {
  }

  share() {
    alert("Share me !!!");
  }

  ngOnDestroy() {
    //this.subscription.unsubscribe();
  }
}
