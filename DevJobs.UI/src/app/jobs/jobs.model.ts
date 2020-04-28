export class JobModel {
    id: string;
    type: string;
    company: string;
    companyUrl: string;
    location: string;
    title: string;
    description: string;
    createdAt: string;
    apply: string;

    constructor(id: string, type: string, company: string, companyUrl: string,
        location: string, title: string, description: string, createdAt: string, apply: string) {
        this.id = id;
        this.type = type;
        this.company = company;
        this.companyUrl = companyUrl;
        this.location = location;
        this.title = title;
        this.description = description;
        this.createdAt = createdAt;
        this.apply = apply;
    }
}