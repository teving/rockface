import { NgModule, Optional, SkipSelf } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { throwIfAlreadyLoaded } from './module-import-guard';
import { LocationConfig } from './config/location.config';

@NgModule({
   imports: [HttpClientModule],
   providers: [LocationConfig]
})
export class CoreModule {
   constructor( @SkipSelf() @Optional() coreModule: CoreModule) {
      throwIfAlreadyLoaded(coreModule, 'CoreModule');
   }
}
