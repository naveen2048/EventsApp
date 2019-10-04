import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SharedModule } from './shared-module/shared-module.module';
import { HomeComponent } from './shared-module/components/home/home.component';


const routes: Routes = [

  { path:'home', loadChildren: './shared-module/shared-module.module#SharedModule' },
  { path:'', pathMatch:'full',redirectTo:'/home' },
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
