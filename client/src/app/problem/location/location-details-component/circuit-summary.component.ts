import { Component, Input } from '@angular/core';

import { LocationCircuitSummary } from '../location-circuit-summary.model';

@Component({
   selector: 'rf-circuit-summary',
   templateUrl: 'circuit-summary.component.html'
})
export class CircuitSummaryComponent {
   @Input() circuit: LocationCircuitSummary;
}
