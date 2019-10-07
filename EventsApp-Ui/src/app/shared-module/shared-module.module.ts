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


@NgModule({
  declarations: [
    HeaderComponent,
    HomeComponent,
    FooterComponent,
    AdRotatorComponent,
    LoginComponent,
    EventsComponent
   
  ],
  imports: [
    CommonModule, FormsModule,SharedRoutingModule,NgbModule
  ],
  exports:[HeaderComponent,FooterComponent,HomeComponent,AdRotatorComponent,LoginComponent]
})
export class SharedModule{ 
  constructor(){
    console.log('shared module loads..')
  }
}
