import { Pipe, PipeTransform } from '@angular/core';
import { eventModel } from '../models/event-model';
import { MessageService } from './shared.service';

@Pipe({
	name: 'filter'
})
export class FilterPipe implements PipeTransform {

  constructor(private messageService: MessageService) {}

  transform(items: eventModel[], filter: any): any {
		if (!items || !filter) {
			return items;
		}
		// filter items array, items which match and return true will be
		// kept, false will be filtered out
		var _filteredItems = items.filter(
			((item) => item.title.indexOf(filter) !== -1) ||
				((item) => item.description.indexOf(filter) !== -1) ||
				((item) => item.location.indexOf(filter.title) !== -1) ||
				((item) => item.category.indexOf(filter.title) !== -1)
    );

    this.messageService.filterEvents(_filteredItems);
    //console.log(_filteredItems);
    return _filteredItems;
	}
}
