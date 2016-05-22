import {Component} from '@angular/core';
import {AlertComponent, DATEPICKER_DIRECTIVES} from 'ng2-bootstrap/ng2-bootstrap';

@Component({
    selector: 'my-app',
    directives: [AlertComponent, DATEPICKER_DIRECTIVES],
    template: '<h3>My First Angular 2 App</h3><alert type="info" value="45">Alert!</alert>'
})
export class AppComponent { }
