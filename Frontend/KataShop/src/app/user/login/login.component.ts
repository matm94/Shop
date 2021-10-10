import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { UserApiDataService } from 'src/app/Shared/user-api-data.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup = new FormGroup({});
  constructor(private formBuilder: FormBuilder, private apiData: UserApiDataService,
              private router: Router) { }

  ngOnInit(): void {

    this.loginForm = this.formBuilder.group(
      {
        email: [''] ,
        password: ['']
      });

    if (localStorage.getItem('token') != null)
      {
        this.router.navigateByUrl('/order/all');
      }
  }
  onSubmit(): void
  {
    this.apiData.Login(this.loginForm.value).subscribe( (data: any) =>
      {
        localStorage.setItem('token', data.token);
        this.router.navigateByUrl('/order/all');
        console.log('User created');
      }, (err) =>
      {
        console.log(err);
      });
  }

}
