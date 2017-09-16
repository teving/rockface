import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';

import { LocationCircuitSummary } from '../location-circuit-summary.model';
import { CircuitSummaryComponent } from './circuit-summary.component';

describe('LocationDetailsComponent', () => {
   beforeEach(async(() => {
      TestBed.configureTestingModule({
         declarations: [CircuitSummaryComponent]
      }).compileComponents();
   }));

   beforeEach(() => {
      this.fixture = TestBed.createComponent(CircuitSummaryComponent);
      this.component = this.fixture.componentInstance;
   });

   describe('onInit', () => {
      describe('when the circuit has a colour', () => {
         it('should display the colour with the grade description', () => {
            this.component.circuit = {
               colour: 'red',
               gradeDescription: 'V1-V2'
            };
            this.fixture.detectChanges();

            const span = this.fixture.debugElement.query(By.css('span'));
            expect(span.nativeElement.textContent).toBe('red - V1-V2');
         });
      });

      describe('when the circuit does not have a colour', () => {
         it('should display the description with the grade description', () => {
            this.component.circuit = {
               colour: null,
               description: 'a circuit',
               gradeDescription: 'V1-V2'
            };
            this.fixture.detectChanges();

            const span = this.fixture.debugElement.query(By.css('span'));
            expect(span.nativeElement.textContent).toBe('a circuit - V1-V2');
         });
      });
   });
});
