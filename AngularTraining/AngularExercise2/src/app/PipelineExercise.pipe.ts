import {Pipe,PipeTransform} from '@angular/core';


@Pipe({name:'PipelineExample'})
export class PipelineExample implements PipeTransform{
 
    transform(data: any,temp:any): any{
        //this is very long string
        var value1 = temp.substr(0,9);
        value1= value1 + '...'
        return value1;
    }
}