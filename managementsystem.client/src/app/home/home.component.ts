import { Component,AfterViewInit } from '@angular/core';

declare var AOS: any;

@Component({
  selector: 'app-home',
  standalone: false,
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements AfterViewInit{

ngAfterViewInit(): void {
    if (AOS) {
      AOS.init({
        once: true,
        duration: 800
      });
    }
  }

}


// import { Component, AfterViewInit } from '@angular/core';

// declare var AOS: any;

// @Component({
//   selector: 'app-home',
//   templateUrl: './home.component.html',
//   styleUrls: ['./home.component.css']
// })
// export class HomeComponent implements AfterViewInit {

//   ngAfterViewInit(): void {
//     if (AOS) {
//       AOS.init({
//         once: true,
//         duration: 800
//       });
//     }
//   }

// }
