import { Component } from '@angular/core';
import { JobService } from './jobs.service';
import { JobModel } from './jobs.model';

@Component({
  selector: 'app-jobs',
  templateUrl: './jobs.component.html',
  styleUrls: ['./jobs.component.scss']
})
export class JobsComponent {
  isBusy = false;
  jobs: JobModel[] = [];
  selectedLocation: string = null;
  selectedLanguage: string = null;

  locations = ["Chicago", "San Francisco", "Phoenix", "London", "Beijing", "Paris"];
  languages = ["Javascript", "Java", "Python", "React", "Ruby", "Go"];

  constructor(private jobService: JobService) { }

  getJobs() {
    this.isBusy = true;
    this.jobService.getJobsForLocationAndDesc(this.selectedLocation, this.selectedLanguage).subscribe(
      res => {
        this.jobs = res;
        this.isBusy = false;
      }, err => {
        console.log(err);
        this.isBusy = false;
      }
    )
  }

}
