import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule} from '@angular/forms';
import { NouisliderModule } from 'ng2-nouislider';
import { JWBootstrapSwitchModule } from 'jw-bootstrap-switch-ng2';
// import { ReactiveFormsModule } from '@angular/forms';

import { BasicelementsComponent } from './basicelements/basicelements.component';
import { NavigationComponent } from './navigation/navigation.component';
import { TypographyComponent } from './typography/typography.component';
import { NucleoiconsComponent } from './nucleoicons/nucleoicons.component';
import { ComponentsComponent } from './components.component';
import { NotificationComponent } from './notification/notification.component';
import { NgbdModalComponent } from './modal/modal.component';
import { NgbdModalContent } from './modal/modal.component';
import { GuestInfoService } from '../shared/services/guestInfo.service';
import { HttpHeaders, HttpClientModule } from '@angular/common/http';
import { HttpModule } from '@angular/http';
import { VolunteerService } from '../shared/services/volunteer.service';
// import { NgMultiSelectDropDownModule } from 'ng-multiselect-dropdown';



@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        HttpClientModule,
        HttpModule,
        NgbModule,
        NouisliderModule,
        // NgMultiSelectDropDownModule.forRoot(),
        JWBootstrapSwitchModule
    ],
    declarations: [
       // ProfileComponent,
        ComponentsComponent,
        BasicelementsComponent,
        NavigationComponent,
        TypographyComponent,
        NucleoiconsComponent,
        NotificationComponent,
        NgbdModalComponent,
        NgbdModalContent
    ],
    entryComponents: [NgbdModalContent],
    exports:[ ComponentsComponent ],
    providers: [GuestInfoService,
        VolunteerService ]
})
export class ComponentsModule { }
