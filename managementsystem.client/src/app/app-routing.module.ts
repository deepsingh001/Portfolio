import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContactComponent } from './contact/contact.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [

    { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: '', redirectTo: 'contact', pathMatch: 'full' },  
  { path: 'contact', component: ContactComponent }
  // { path: '**', redirectTo: 'contact' }
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }