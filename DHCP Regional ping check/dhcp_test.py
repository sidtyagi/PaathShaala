def fetch_region_code(line):
    region_code=line.split(',')[0].split('-')[1]
    return region_code

def create_dhcp_mapping(f_name):
    
    dhcp_dict={}
    f=open(f_name)
    for line in f:
        line=line.split(':')        
        dhcp_dict[line[0]]=line[1]
    return dhcp_dict

if __name__=='__main__':
    
    dhcp_mapping=create_dhcp_mapping('Mapping.txt')
    print dhcp_mapping
        
