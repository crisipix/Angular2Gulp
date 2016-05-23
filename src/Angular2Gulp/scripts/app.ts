import {Component} from '@angular/core';
import {AlertComponent, DATEPICKER_DIRECTIVES, ProgressbarComponent} from 'ng2-bootstrap/ng2-bootstrap';

@Component({
    selector: 'my-app',
    directives: [AlertComponent, DATEPICKER_DIRECTIVES, ProgressbarComponent],
    //template: '<h3>My First Angular 2 App</h3><alert type="info" value="45">Alert!</alert>'
    //template: `
    //        <h3>My First Angular 2 App</h3>
    //        <alert type="info" value="45">Alert!</alert>
    //        <progressbar value="25"></progressbar>
    //        `
    templateUrl : './views/appView.html'
})
export class AppComponent { }
