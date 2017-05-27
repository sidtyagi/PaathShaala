import os
def fetch_region_code(line):
    print line
    region_code=line.split(',')[0].split('-')[1]
    return region_code

def create_dhcp_mapping(f_name):
    
    dhcp_dict={}
    f=open(f_name)
    for line in f:
        line=line.split(':')        
        dhcp_dict[line[0]]=line[1]
    return dhcp_dict

def ping_dest(ip):
    os.system('ping '+ip)

if __name__=='__main__':
    
    dhcp_mapping=create_dhcp_mapping('Mapping.txt')
    print dhcp_mapping
        
    #ping the dest ip based on the regional server mapping
    f=open('ip_list.txt')
    for line in f:
        region_code=fetch_region_code(line)
        dhcp_server=dhcp_mapping[region_code]
        print 'the corresponding dhcp server %s'%dhcp_server
        ping_dest(dhcp_server)
