import { eventModel } from './../../../models/event-model';
import { Component, OnInit } from '@angular/core';
import { FilterPipe } from '../../filter.pipe';
import { MessageService } from '../../shared.service';

@Component({
	selector: 'app-header',
	templateUrl: './header.component.html',
	styleUrls: [ './header.component.css' ]
})
export class HeaderComponent implements OnInit {


	searchText: string;

	constructor(private filterPipe: FilterPipe, private messageService: MessageService) {
    //this.messageService.filterEvents(this.data);
  }

	ngOnInit() {}

	applyFilter() {
		//if (this.searchText != '') this.filterPipe.transform(this.data, this.searchText);
	}
}
