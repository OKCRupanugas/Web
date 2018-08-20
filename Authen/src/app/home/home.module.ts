import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule  } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RouterModule } from '@angular/router';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { HomeComponent } from './home.component';

import { ComponentsModule } from '../components/components.module';
import { QuillEditorModule } from '../shared/ngx-quill-editor/quillEditor.module';
import { EnquiryComponent } from '../enquiry/enquiry.component';
import { GuestInfoComponent } from '../components/guestinfo/guestinfo.component';
import { VolunteerComponent } from '../components/volunteer/volunteer.component';
import { Headers, RequestOptions } from '@angular/http';
import { Ng2YaTableModule } from 'ng2-ya-table';
import { SelectDropDownModule } from 'ngx-select-dropdown';


@NgModule({
    imports: [
        CommonModule,
        BrowserModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        ComponentsModule,
         NgbModule,
         QuillEditorModule,
         Ng2YaTableModule.forRoot(),
         SelectDropDownModule
    ],
    declarations: [ HomeComponent,
        EnquiryComponent,
    GuestInfoComponent,
    VolunteerComponent
],
    exports: [HomeComponent ],
    providers: []
})
export class HomeModule { }
