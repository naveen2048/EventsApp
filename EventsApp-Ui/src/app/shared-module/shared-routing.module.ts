import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { EventDetailsComponent } from './components/events/event-details/event-details.component';


const routes: Routes = [
  {
    path:'', component:HomeComponent,
  },
  {path:'event-details/:id',  component: EventDetailsComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SharedRoutingModule {

 }
