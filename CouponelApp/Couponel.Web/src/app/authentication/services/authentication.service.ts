import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AuthenticationService {
  public endpoint: string =
        'https://localhost:5001/api/v1/auth';
  constructor(private readonly httpClient: HttpClient) {}

  public login(data: unknown): Observable<unknown> {
    return this.httpClient.post(`${this.endpoint}/login`, data);
  }

  public register(data: unknown): Observable<unknown> {
    console.log(data);
    return this.httpClient.post(`${this.endpoint}/register`, data);
  }
}
