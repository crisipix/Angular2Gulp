///<reference path="./../typings/browser/ambient/es6-shim/index.d.ts"/>
import {bootstrap}    from '@angular/platform-browser-dynamic';
import {AppComponent} from './app';
import {enableProdMode} from '@angular/core';

enableProdMode();
bootstrap(AppComponent);