# Angular2Gulp
Angular 2 with Gulp



cmd.exe /c gulp --tasks-simple
'gulp' is not recognized as an internal or external command,
operable program or batch file.

 npm install --global gulp-cli
 ....Angular2Gulp> gulp -v
[19:42:14] CLI version 1.2.1
[19:42:14] Local version 3.9.1



Tools > PRojects and solutions > External Web Tools > PATH over the Dev env dir\




Angular 2 is running in the development mode. 
Call enableProdMode() to enable the production mode.

his console message should link to docs explaining what enableProdMode is and an example of how exactly to enable it. For example, something like this would have been much clearer (not sure if this is how you do it exactly):

import {enableProdMode} from "angular2/core";

enableProdMode();


Error: SyntaxError: Expected ';'
I hate this error. it's horrible the last thing that was called isn't correct so that's why it throws it. 
Error: SyntaxError: Expected ';'
	Evaluating http://localhost:52788/traceur
	Error loading http://localhost:52788/traceur
	Error loading http://localhost:52788/appScripts/appCallService.js as "./appCallService" from http://localhost:52788/appScripts/appCall.js

	
	EXCEPTION: TypeError: Unable to set property 'endSourceSpan' of undefined or null reference
	 <button (click)="deletePost()" Delete Post </button>
	  MISSING > 
	  <button (click)="deletePost()"> Delete Post </button>