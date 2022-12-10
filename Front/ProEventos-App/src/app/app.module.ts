import { EventoService } from './services/evento.services';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventosComponent } from './eventos/eventos.component';
import { PalestrantesComponent } from './palestrantes/palestrantes.component';
import { NavComponent } from './nav/nav.component';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { DateTimeFormatPipe } from './helpers/DateTimeFormat.pipe';

/* ngx module */
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
// Componentes
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ModalModule } from 'ngx-bootstrap/modal';
// import { ToastrModule } from 'ngx-toastr';



// var toastr = {
//   timeOut: 3000,
//   positionClass: 'toast-bottom-right',
//   preventDuplicates: true,
//   ProgressBar: true
// }

@NgModule({
  declarations: [
    AppComponent,
    EventosComponent,
    PalestrantesComponent,
    NavComponent,
    DateTimeFormatPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    CollapseModule.forRoot(),
    BsDropdownModule.forRoot(),
    TooltipModule.forRoot(),
    ModalModule.forRoot(),
    // ToastrModule.forRoot(toastr),
    FormsModule
  ],
  providers: [
    EventoService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
