import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { HomeComponent } from './components/home/home.component';
import { AdRotatorComponent } from './components/ad-rotator/ad-rotator.component';
import { NgbCarousel, NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { LoginComponent } from './components/login/login.component';
import { SharedRoutingModule } from './shared-routing.module';
import { EventsComponent } from './components/events/events.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

//Material
import {
  MatIconModule, MatButtonModule, MatChipsModule, MatMenuModule
} from '@angular/material';
import { EventDetailsComponent } from './components/events/event-details/event-details.component';
import { FilterPipe } from './filter.pipe';
import { MessageService } from './shared.service';

const _MaterialComponents = [
  MatIconModule,
  MatButtonModule,
  MatChipsModule,
  MatMenuModule
];

@NgModule({
  declarations: [
    HeaderComponent,
    HomeComponent,
    FooterComponent,
    AdRotatorComponent,
    LoginComponent,
    EventsComponent,
    EventDetailsComponent,
    FilterPipe
  ],
  imports: [
    CommonModule,
    FormsModule,
    SharedRoutingModule,
    NgbModule,
    _MaterialComponents
  ],
  exports:[
    HeaderComponent,
    FooterComponent,
    HomeComponent,
    AdRotatorComponent,
    LoginComponent,
    EventsComponent,
    EventDetailsComponent,
    _MaterialComponents
  ],
  providers: [
    MessageService,
    FilterPipe
  ]
})
export class SharedModule{
  constructor(){
    console.log('shared module loads..')
  }
}
