import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

@Injectable()
export class TournamentService {
  constructor(private http: HttpClient) {}
  private data: String[] = ["t1", "t2"];


  getFakeData(): any[] {
    this.http
    .get("assets/fake-data/tournament-schedule.json")
    .subscribe(res => console.log(res));
  return ["lil", 1];
  }

  getRealData(): any[] {
    this.http
      .get("http://localhost:5000/api/tournaments/")
      .subscribe(res => console.log(res));
    return ["lil", 1];
  }
}
