import { Component, Input } from '@angular/core';

import { LocationListItem } from '../location-list-item.model';

@Component({
   selector: 'rf-location-list-item',
   templateUrl: './location-list-item.component.html'
})
export class LocationListItemComponent {
   @Input() location: LocationListItem;
}
