import { UserApiDataService } from './../../Shared/user-api-data.service';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  registrationForm: FormGroup = new FormGroup({});
  constructor(private formBuilder: FormBuilder, private apiData: UserApiDataService) { }

  ngOnInit(): void {

    this.registrationForm = this.formBuilder.group(
      {
        login: [''] ,
        password: [''] ,
        email: ['']
      });
  }

  onSubmit(): void
  {
    this.apiData.Registration(this.registrationForm.value).subscribe( data =>
      {
        console.log('User created');
      }, (err) =>
      {
        console.log(err);
      });
  }

}
