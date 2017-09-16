import { NgModule, Optional, SkipSelf } from '@angular/core';
import { throwIfAlreadyLoaded } from './module-import-guard';

@NgModule()
export class CoreModule {
   constructor( @SkipSelf() @Optional() coreModule: CoreModule) {
      throwIfAlreadyLoaded(coreModule, 'CoreModule');
   }
}
