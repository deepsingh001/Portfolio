import { Component, OnInit } from '@angular/core';
declare var AOS: any;
@Component({
  selector: 'app-contact',
  standalone: false,
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})


export class ContactComponent implements OnInit {
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

   formData = {
    name: '',
    email: '',
    subject: '',
    message: ''
  };

  submitted = false;

  handleSubmit(event: Event) {
    event.preventDefault();

    console.log(this.formData);
    this.submitted = true;

    setTimeout(() => {
      this.submitted = false;
      this.formData = {
        name: '',
        email: '',
        subject: '',
        message: ''
      };
    }, 3000);
  }
}
